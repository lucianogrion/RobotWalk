using System.Collections.Generic;

Console.WriteLine(RobotWalk(new int[] { 4, 4, 3, 2, 2, 3 }));

Console.WriteLine(RobotWalk(new int[] { 7, 5, 4, 5, 2, 3 }));

Console.WriteLine(RobotWalk(new int[] { 1345, 1497, 1342, 1487, 1341, 1479, 1338, 1472, 1333, 1467, 1330, 1458, 1322, 1452, 1314, 1448, 1308, 1442, 1301, 1434, 1297, 1430, 1294, 1424, 1290, 1416, 1280, 1407, 1271, 1400, 1263, 1398, 1253, 1389, 1244, 1388, 1238, 1380, 1236, 1372, 1228, 1365, 1220, 1363, 1219, 1354, 1210, 1352, 1207, 1346 }));

Console.WriteLine(RobotWalk(new int[] { 5, 5,5, 5,  }));


bool RobotWalk(int[] a)
{
    SortedSet<string> distinctNumbers = new();

    //List<string> list = new List<string>();
    int Xinit = 0, Yinit = 0;
    distinctNumbers.Add(string.Format("{0}-{1}" , Xinit, Yinit));

    //foreach (int step in a)
    for (int s = 0; s < a.Count(); s++)
    {
        if (s % 4 == 0)
        {
            for (int i = 0; i < a[s]; i++)
            {
                Yinit = Yinit + 1;
                if (!distinctNumbers.Add(string.Format("{0}-{1}", Xinit, Yinit)))
                {
                    return true;
                }
                

            }
        }
        if (s % 4 == 1)
        {
            for (int i = 0; i < a[s]; i++)
            {
                Xinit = Xinit + 1;
                if (!distinctNumbers.Add(string.Format("{0}-{1}", Xinit, Yinit)))
                {
                    return true;
                }
            }
        }

        if (s % 4 == 2)
        {
            for (int i = 0; i < a[s]; i++)
            {
                Yinit--;
                if (!distinctNumbers.Add(string.Format("{0}-{1}", Xinit, Yinit)))
                {
                    return true;
                }
            }
        }
        if (s % 4 == 3)
        {
            for (int i = 0; i < a[s]; i++)
            {
                Xinit--;
                if (!distinctNumbers.Add(string.Format("{0}-{1}", Xinit, Yinit)))
                {
                    return true;
                }
            }
        }
        //currentStep++;
    }


    return false;
}


class Point
{
    public int x;
    public int y;

}
