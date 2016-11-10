using System;
class Test
{
    static void Main()
    {

        int usSum;
        int usCnt;

        usSum = 10; usCnt = 2;

        switch (usCnt)

        {
            case 3:

                {
                    usSum = usSum + 2;
                    break;
                }

            default:
                {
                    break;
                }

            case 2:

                {
                    usSum = usSum * 3;
                    goto case 3;
                }

        }

    }

