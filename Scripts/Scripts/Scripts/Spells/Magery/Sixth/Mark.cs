using System;
using Server.Items;
using Server.Targeting;
using Server.Network;
using Server.Regions;

namespace Server.Spells.Sixth
{
	public class MarkSpell : MagerySpell
	{
		private static SpellInfo m_Info = new SpellInfo(
				"Mark", "Kal Por Ylem",
				218,
				9002,
				Reagent.BlackPearl,
				Reagent.Bloodmoss,
				Reagent.MandrakeRoot
			);

		public override SpellCircle Circle { get { return SpellCircle.Sixth; } }

		public MarkSpell( Mobile caster, Item scroll )
			: base( caster, scroll, m_Info )
		{
		}

        public static bool CheckAltar(Point3D p, Map map)
        {
            if (map == null || map == Map.Internal)
                return false;

            Sector sector = map.GetSector(p.X, p.Y);

            for (int i = 0; i < sector.Items.Count; ++i)
            {
                Item item = sector.Items[i];

                if (item is AbbatoirAddon)
                {
                    return true;
                }
            }

            return false;
        }

		public override void OnCast()
		{
			Caster.Target = new InternalTarget( this );
		}

		public override bool CheckCast()
		{
			if( !base.CheckCast() )
				return false;

			return SpellHelper.CheckTravel( Caster, TravelCheckType.Mark );
		}

		public void Target( RecallRune rune )
		{
			if( !Caster.CanSee( rune ) )
			{
				Caster.SendLocalizedMessage( 500237 ); // Target can not be seen.
			}
			else if( !SpellHelper.CheckTravel( Caster, TravelCheckType.Mark ) )
			{
			}

            else if (SpellHelper.CheckMulti(Caster.Location, Caster.Map, !Core.AOS))
            {
                Caster.SendMessage("That location is blocked.");
            }

            else if (!CheckAltar(Caster.Location, Caster.Map))
            {
                Caster.SendMessage("You must be on an altar to preform this spell.");
            }

            else if (!rune.IsChildOf(Caster.Backpack))
            {
                Caster.LocalOverheadMessage(MessageType.Regular, 0x3B2, 1062422); // You must have this rune in your backpack in order to mark it.
            }

            else if (CheckSequence())
            {
                rune.Mark(Caster);

                Caster.PlaySound(0x1FA);
                Effects.SendLocationEffect(Caster, Caster.Map, 14201, 16);
            }

			FinishSequence();
		}

		private class InternalTarget : Target
		{
			private MarkSpell m_Owner;

			public InternalTarget( MarkSpell owner )
				: base( 12, false, TargetFlags.None )
			{
				m_Owner = owner;
			}

			protected override void OnTarget( Mobile from, object o )
			{
				if( o is RecallRune )
				{
					m_Owner.Target( (RecallRune)o );
				}
				else
				{
					from.Send( new MessageLocalized( from.Serial, from.Body, MessageType.Regular, 0x3B2, 3, 501797, from.Name, "" ) ); // I cannot mark that object.
				}
			}

			protected override void OnTargetFinish( Mobile from )
			{
				m_Owner.FinishSequence();
			}
		}
	}
}