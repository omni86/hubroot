using System;

namespace Server.Items
{
	public class StatuetteDyeTub : DyeTub
	{
		public override bool AllowDyables { get { return false; } }
		public override bool AllowStatuettes { get { return true; } }
		public override int TargetMessage { get { return 1049777; } } // Target the statuette to dye
		public override int FailMessage { get { return 1049778; } } // You can only dye veteran reward statuettes with this tub.
		public override int LabelNumber { get { return 1049741; } } // Reward Statuette Dye Tub
		public override CustomHuePicker CustomHuePicker { get { return CustomHuePicker.LeatherDyeTub; } }

		[Constructable]
		public StatuetteDyeTub()
		{
			LootType = LootType.Blessed;
		}

		public StatuetteDyeTub( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}