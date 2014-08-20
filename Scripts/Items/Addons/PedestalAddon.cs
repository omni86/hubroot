/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class PedestalAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PedestalAddonDeed();
			}
		}

		[ Constructable ]
		public PedestalAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 7978 );
			AddComponent( ac, 0, 0, 0 );

		}

		public PedestalAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class PedestalAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PedestalAddon();
			}
		}

		[Constructable]
		public PedestalAddonDeed()
		{
			Name = "Pedestal";
		}

		public PedestalAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}