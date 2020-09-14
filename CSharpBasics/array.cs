class Array
{
    void Learn1DArrays()
    {
        int[] ages = new int[5];
        ages[0] = 23;
        ages[1] = 32;
        ages[2] = 324;
        ages[3] = 54;
        ages[4] = 11;
        int[] ages2 = new int[] { 34, 34, 65, 76 };
        int[] ages3 = { 34, 34, 65, 76 };
    }
    void LearnMDArrays()
    {
        int[,] multable = new int[3, 4];
        multable[0, 0] = 23;
        double[,,] multable2 = new double[3, 4, 2];
        multable2[0, 0, 0] = 2.56;


        byte[,] numbers = { { 10, 27, 32 }, { 44, 45, 22 } };
    }
    void LearnJaggedArrays()
    {
        int[][] mulTable = new int[3][];
        mulTable[0] = new int[] { 2, 3, 5 };
        mulTable[1] = new int[] { 2, 4 };
        mulTable[2] = new int[] { 3, 5, 6, 4, 3 };
    }
}