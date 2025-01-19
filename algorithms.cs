


namespace sorting_algorithms
{

    public class Algorithms
    {

        public static void Bubblesort(List<int> list){

            bool needsorting = true;
            for(int i = 0;i < list.Count-1 && needsorting;i++){

                needsorting = false;

                for(int j = 0; j < list.Count-1-i;j++){

                    if(list[j] > list[j+1]){

                        needsorting = true;

                        int swappednumber = list[j+1];
                        list[j+1] = list[j];
                        list[j] = swappednumber;

                    }
                }
            }
        }


    

    }
}

