﻿namespace GlobalLib.Support.Underground2.Framework
{
	public static partial class CareerManager
	{
		private static unsafe byte[] WriteGCareerBrands(Utils.MemoryWriter mw, Database.Underground2 db)
		{
			var result = new byte[8 + db.GCareerBrands.Length * 0x44];
			int offset = 8; // for calculating offsets
			fixed (byte* byteptr_t = &result[0])
			{
				*(uint*)byteptr_t = Reflection.ID.CareerInfo.BRAND_BLOCK; // write ID
				*(int*)(byteptr_t + 4) = result.Length - 8; // write size
				foreach (var brand in db.GCareerBrands.Classes.Values)
				{
					brand.Assemble(byteptr_t + offset, mw);
					offset += 0x44;
				}
			}
			return result;
		}
	}
}