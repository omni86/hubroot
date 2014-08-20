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
	public class AnkhBannerEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AnkhBannerEastAddonDeed();
			}
		}

		[Constructable]
		public AnkhBannerEastAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 5656 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 5655 );
			AddComponent( ac, 0, 1, 0 );

		}

		public AnkhBannerEastAddon( Serial serial )
			: base( serial )
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

	public class AnkhBannerEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AnkhBannerEastAddon();
			}
		}

		[Constructable]
		public AnkhBannerEastAddonDeed()
		{
			Name = "AnkhBannerEast";
		}

		public AnkhBannerEastAddonDeed( Serial serial )
			: base( serial )
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

	public class AnkhBannerSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AnkhBannerSouthAddonDeed();
			}
		}

		[Constructable]
		public AnkhBannerSouthAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 5544 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 5545 );
			AddComponent( ac, 1, 0, 0 );

		}

		public AnkhBannerSouthAddon( Serial serial )
			: base( serial )
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

	public class AnkhBannerSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AnkhBannerSouthAddon();
			}
		}

		[Constructable]
		public AnkhBannerSouthAddonDeed()
		{
			Name = "AnkhBannerSouth";
		}

		public AnkhBannerSouthAddonDeed( Serial serial )
			: base( serial )
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
}