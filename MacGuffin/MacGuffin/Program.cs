using System.Numerics;

public class MacGuffin
{
    private ushort[,] S =
    {
            {
            0x0002, 0x0000, 0x0000, 0x0003, 0x0003, 0x0001, 0x0001, 0x0000,
            0x0000, 0x0002, 0x0003, 0x0000, 0x0003, 0x0003, 0x0002, 0x0001,
            0x0001, 0x0002, 0x0002, 0x0000, 0x0000, 0x0002, 0x0002, 0x0003,
            0x0001, 0x0003, 0x0003, 0x0001, 0x0000, 0x0001, 0x0001, 0x0002,
            0x0000, 0x0003, 0x0001, 0x0002, 0x0002, 0x0002, 0x0002, 0x0000,
            0x0003, 0x0000, 0x0000, 0x0003, 0x0000, 0x0001, 0x0003, 0x0001,
            0x0003, 0x0001, 0x0002, 0x0003, 0x0003, 0x0001, 0x0001, 0x0002,
            0x0001, 0x0002, 0x0002, 0x0000, 0x0001, 0x0000, 0x0000, 0x0003
            },

            {
            0x000c, 0x0004, 0x0004, 0x000c, 0x0008, 0x0000, 0x0008, 0x0004,
            0x0000, 0x000c, 0x000c, 0x0000, 0x0004, 0x0008, 0x0000, 0x0008,
            0x000c, 0x0008, 0x0004, 0x0000, 0x0000, 0x0004, 0x000c, 0x0008,
            0x0008, 0x0000, 0x0000, 0x000c, 0x0004, 0x000c, 0x0008, 0x0004,
            0x0000, 0x000c, 0x0008, 0x0008, 0x0004, 0x0008, 0x000c, 0x0004,
            0x0008, 0x0004, 0x0000, 0x000c, 0x000c, 0x0000, 0x0004, 0x0000,
            0x0004, 0x000c, 0x0008, 0x0000, 0x0008, 0x0004, 0x0000, 0x0008,
            0x000c, 0x0000, 0x0004, 0x0004, 0x0000, 0x0008, 0x000c, 0x000c
            },

            {
            0x0020, 0x0030, 0x0000, 0x0010, 0x0030, 0x0000, 0x0020, 0x0030,
            0x0000, 0x0010, 0x0010, 0x0000, 0x0030, 0x0000, 0x0010, 0x0020,
            0x0010, 0x0000, 0x0030, 0x0020, 0x0020, 0x0010, 0x0010, 0x0020,
            0x0030, 0x0020, 0x0000, 0x0030, 0x0000, 0x0030, 0x0020, 0x0010,
            0x0030, 0x0010, 0x0000, 0x0020, 0x0000, 0x0030, 0x0030, 0x0000,
            0x0020, 0x0000, 0x0030, 0x0030, 0x0010, 0x0020, 0x0000, 0x0010,
            0x0030, 0x0000, 0x0010, 0x0030, 0x0000, 0x0020, 0x0020, 0x0010,
            0x0010, 0x0030, 0x0020, 0x0010, 0x0020, 0x0000, 0x0010, 0x0020
            },

            {
            0x0040, 0x00c0, 0x00c0, 0x0080, 0x0080, 0x00c0, 0x0040, 0x0040,
            0x0000, 0x0000, 0x0000, 0x00c0, 0x00c0, 0x0000, 0x0080, 0x0040,
            0x0040, 0x0000, 0x0000, 0x0040, 0x0080, 0x0000, 0x0040, 0x0080,
            0x00c0, 0x0040, 0x0080, 0x0080, 0x0000, 0x0080, 0x00c0, 0x00c0,
            0x0080, 0x0040, 0x0000, 0x00c0, 0x00c0, 0x0000, 0x0000, 0x0000,
            0x0080, 0x0080, 0x00c0, 0x0040, 0x0040, 0x00c0, 0x00c0, 0x0080,
            0x00c0, 0x00c0, 0x0040, 0x0000, 0x0040, 0x0040, 0x0080, 0x00c0,
            0x0040, 0x0080, 0x0000, 0x0040, 0x0080, 0x0000, 0x0000, 0x0080
            },

            {
            0x0000, 0x0200, 0x0200, 0x0300, 0x0000, 0x0000, 0x0100, 0x0200,
            0x0100, 0x0000, 0x0200, 0x0100, 0x0300, 0x0300, 0x0000, 0x0100,
            0x0200, 0x0100, 0x0100, 0x0000, 0x0100, 0x0300, 0x0300, 0x0200,
            0x0300, 0x0100, 0x0000, 0x0300, 0x0200, 0x0200, 0x0300, 0x0000,
            0x0000, 0x0300, 0x0000, 0x0200, 0x0100, 0x0200, 0x0300, 0x0100,
            0x0200, 0x0100, 0x0300, 0x0200, 0x0100, 0x0000, 0x0200, 0x0300,
            0x0300, 0x0000, 0x0300, 0x0300, 0x0200, 0x0000, 0x0100, 0x0300,
            0x0000, 0x0200, 0x0100, 0x0000, 0x0000, 0x0100, 0x0200, 0x0100
            },

            {
            0x0800, 0x0800, 0x0400, 0x0c00, 0x0800, 0x0000, 0x0c00, 0x0000,
            0x0c00, 0x0400, 0x0000, 0x0800, 0x0000, 0x0c00, 0x0800, 0x0400,
            0x0000, 0x0000, 0x0c00, 0x0400, 0x0400, 0x0c00, 0x0000, 0x0800,
            0x0800, 0x0000, 0x0400, 0x0c00, 0x0400, 0x0400, 0x0c00, 0x0800,
            0x0c00, 0x0000, 0x0800, 0x0400, 0x0c00, 0x0000, 0x0400, 0x0800,
            0x0000, 0x0c00, 0x0800, 0x0400, 0x0800, 0x0c00, 0x0400, 0x0800,
            0x0400, 0x0c00, 0x0000, 0x0800, 0x0000, 0x0400, 0x0800, 0x0400,
            0x0400, 0x0000, 0x0c00, 0x0000, 0x0c00, 0x0800, 0x0000, 0x0c00
            },

            {
            0x0000, 0x3000, 0x3000, 0x0000, 0x0000, 0x3000, 0x2000, 0x1000,
            0x3000, 0x0000, 0x0000, 0x3000, 0x2000, 0x1000, 0x3000, 0x2000,
            0x1000, 0x2000, 0x2000, 0x1000, 0x3000, 0x1000, 0x1000, 0x2000,
            0x1000, 0x0000, 0x2000, 0x3000, 0x0000, 0x2000, 0x1000, 0x0000,
            0x1000, 0x0000, 0x0000, 0x3000, 0x3000, 0x3000, 0x3000, 0x2000,
            0x2000, 0x1000, 0x1000, 0x0000, 0x1000, 0x2000, 0x2000, 0x1000,
            0x2000, 0x3000, 0x3000, 0x1000, 0x0000, 0x0000, 0x2000, 0x3000,
            0x0000, 0x2000, 0x1000, 0x0000, 0x3000, 0x1000, 0x0000, 0x2000
            },

            {
            0xc000, 0x4000, 0x0000, 0xc000, 0x8000, 0xc000, 0x0000, 0x8000,
            0x0000, 0x8000, 0xc000, 0x4000, 0xc000, 0x4000, 0x4000, 0x0000,
            0x8000, 0x8000, 0xc000, 0x4000, 0x4000, 0x0000, 0x8000, 0xc000,
            0x4000, 0x0000, 0x0000, 0x8000, 0x8000, 0xc000, 0x4000, 0x0000,
            0x4000, 0x0000, 0xc000, 0x4000, 0x0000, 0x8000, 0x4000, 0x4000,
            0xc000, 0x0000, 0x8000, 0x8000, 0x8000, 0x8000, 0x0000, 0xc000,
            0x0000, 0xc000, 0x0000, 0x8000, 0x8000, 0xc000, 0xc000, 0x0000,
            0xc000, 0x4000, 0x4000, 0x4000, 0x4000, 0x0000, 0x8000, 0xc000
            }
        };
    private ushort[,] SB =
    {
            {2, 5, 6, 9, 11, 13},
            {1, 4, 7, 10, 8, 14},
            {3, 6, 8, 13, 0, 15},
            {12, 14, 1, 2, 4, 10},
            {0, 10, 3, 14, 6, 12},
            {7, 8, 12, 15, 1, 5},
            {9, 15, 5, 11, 2, 7},
            {11, 13, 0, 4, 3, 9}
        };
    private ushort[,] IN =
    {
            {0x0036, 0x06C0, 0x6900},
            {0x5048, 0x2106, 0x8411},
            {0x8601, 0x4828, 0x10C4},
            {0x2980, 0x9011, 0x022A}
        };
    private ushort[] OUT =
    {
            0x000F, 0x00F0, 0x3300, 0xCC00
        };
    private ushort[] val = new ushort[96];
    private ushort[] ST = new ushort[65536];

    public void KeySetup(BigInteger ZOV)
    {
        for (int i = 0; i < 65536; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                ST[i] |= S[j, ((i >>> SB[j, 0]) & 1)
                      | (((i >>> SB[j, 1]) & 1) << 1)
                      | (((i >>> SB[j, 2]) & 1) << 2)
                      | (((i >>> SB[j, 3]) & 1) << 3)
                      | (((i >>> SB[j, 4]) & 1) << 4)
                      | (((i >>> SB[j, 5]) & 1) << 5)];
            }
        }

        for (int i = 0; i < 2; i++)
        {
            byte[] K = new byte[8];
            Array.Copy(ZOV.ToByteArray(), 8 * i, K, 0, 8);

            for (int j = 0; j < 32; j++)
            {
                Block_Encrypt(K);

                val[3 * j] ^= (ushort)(K[0] | (K[1] << 8));
                val[3 * j + 1] ^= (ushort)(K[2] | (K[3] << 8));
                val[3 * j + 2] ^= (ushort)(K[4] | (K[5] << 8));
            }
        }
    }

    public BigInteger Encrypt(BigInteger ZOV)
    {
        byte[] Data = Block_Encrypt(ZOV.ToByteArray());
        return ArrayToNum(Data);
    }

    public BigInteger Decrypt(BigInteger ZOV)
    {
        byte[] Data = Block_Decrypt(ZOV.ToByteArray());
        return ArrayToNum(Data);
    }

    private byte[] Block_Encrypt(byte[] BLK)
    {
        ushort r_0, r_1, r_2, r_3, a, b, c;
        byte Z = 0;

        r_0 = (ushort)(BLK[0] | (BLK[1] << 8));
        r_1 = (ushort)(BLK[2] | (BLK[3] << 8));
        r_2 = (ushort)(BLK[4] | (BLK[5] << 8));
        r_3 = (ushort)(BLK[6] | (BLK[7] << 8));

        for (int i = 0; i < 8; i++)
        {
            a = (ushort)(r_1 ^ (val[Z++])); b = (ushort)(r_2 ^ (val[Z++])); c = (ushort)(r_3 ^ (val[Z++]));

            r_0 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));

            a = (ushort)(r_2 ^ (val[Z++])); b = (ushort)(r_3 ^ (val[Z++])); c = (ushort)(r_0 ^ (val[Z++]));

            r_1 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));

            a = (ushort)(r_3 ^ (val[Z++])); b = (ushort)(r_0 ^ (val[Z++])); c = (ushort)(r_1 ^ (val[Z++]));

            r_2 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));

            a = (ushort)(r_0 ^ (val[Z++])); b = (ushort)(r_1 ^ (val[Z++])); c = (ushort)(r_2 ^ (val[Z++]));

            r_3 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));
        }

        BLK[0] = (byte)(r_0); BLK[1] = (byte)(r_0 >> 8);
        BLK[2] = (byte)(r_1); BLK[3] = (byte)(r_1 >> 8);
        BLK[4] = (byte)(r_2); BLK[5] = (byte)(r_2 >> 8);
        BLK[6] = (byte)(r_3); BLK[7] = (byte)(r_3 >> 8);

        return BLK;
    }

    private byte[] Block_Decrypt(byte[] BLK)
    {

        ushort r_0, r_1, r_2, r_3, a, b, c;
        byte Z = 96;

        r_0 = (ushort)(BLK[0] | (BLK[1] << 8));
        r_1 = (ushort)(BLK[2] | (BLK[3] << 8));
        r_2 = (ushort)(BLK[4] | (BLK[5] << 8));
        r_3 = (ushort)(BLK[6] | (BLK[7] << 8));

        for (int i = 0; i < 8; i++)
        {
            c = (ushort)(r_2 ^ (val[--Z])); b = (ushort)(r_1 ^ (val[--Z])); a = (ushort)(r_0 ^ (val[--Z]));

            r_3 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));

            c = (ushort)(r_1 ^ (val[--Z])); b = (ushort)(r_0 ^ (val[--Z])); a = (ushort)(r_3 ^ (val[--Z]));

            r_2 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));

            c = (ushort)(r_0 ^ (val[--Z])); b = (ushort)(r_3 ^ (val[--Z])); a = (ushort)(r_2 ^ (val[--Z]));

            r_1 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));

            c = (ushort)(r_3 ^ (val[--Z])); b = (ushort)(r_2 ^ (val[--Z])); a = (ushort)(r_1 ^ (val[--Z]));

            r_0 ^= (ushort)
                 ((OUT[0] & ST[(a & IN[0, 0]) | (b & IN[0, 1]) | (c & IN[0, 2])])
                | (OUT[1] & ST[(a & IN[1, 0]) | (b & IN[1, 1]) | (c & IN[1, 2])])
                | (OUT[2] & ST[(a & IN[2, 0]) | (b & IN[2, 1]) | (c & IN[2, 2])])
                | (OUT[3] & ST[(a & IN[3, 0]) | (b & IN[3, 1]) | (c & IN[3, 2])]));
        }

        BLK[0] = (byte)(r_0); BLK[1] = (byte)(r_0 >> 8);
        BLK[2] = (byte)(r_1); BLK[3] = (byte)(r_1 >> 8);
        BLK[4] = (byte)(r_2); BLK[5] = (byte)(r_2 >> 8);
        BLK[6] = (byte)(r_3); BLK[7] = (byte)(r_3 >> 8);

        return BLK;
    }

    public BigInteger ArrayToNum(object ZOV)
    {
        BigInteger result = 0;

        if (ZOV is uint[] Z)
        {
            for (int i = 3; i >= 0; i--)
            {
                result <<= 32;
                result |= Z[i];
            }
        }
        else if (ZOV is byte[] V)
        {
            for (int i = 7; i >= 0; i--)
            {
                result <<= 8;
                result |= V[i];
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        MacGuffin MacGuffin = new MacGuffin();
        BigInteger Key = GenNum(128); //128 bit;
        BigInteger Text = GenNum(64); //64 bit;

        MacGuffin.KeySetup(Key);
        BigInteger NewText = MacGuffin.Encrypt(Text);
        BigInteger OldText = MacGuffin.Decrypt(NewText);

        Console.WriteLine($"{Text}\t<-- ORIGINAL TEXT");
        Console.WriteLine($"{NewText}\t<-- ENCRYPTED TEXT");
        Console.WriteLine($"{OldText}\t<-- DECRYPTED TEXT");
    }

    static BigInteger GenNum(int size)
    {
        BigInteger Num = 1;

        for (int i = 0; i < size / 8; i++)
        {
            Random Random = new Random();
            byte ez = (byte)Random.Next(0, 256);

            Num = Num << 8;

            if (i == 0)
            {
                Num = Num >>> 1;
            }

            Num |= ez;
        }

        return Num;
    }
}