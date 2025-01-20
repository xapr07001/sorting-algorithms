


using System.Security.Cryptography.X509Certificates;

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

                        (list[j], list[j+1]) = (list[j+1], list[j]);
                    }
                }
            }
        }

        public static void Selectionsort(List<int> list){


            for(int i = 0;i < list.Count-2;i++){

                int min = i;

                for(int j = i+1;j < list.Count;j++){
                    if(list[j] < list[min]){
                        min = j;
                    }
                }
                
                (list[min], list[i]) = (list[i], list[min]);
            }

        }
    
        public static void Insertionsort(List<int> list){

            for(int i = 1; i < list.Count; ++i){
                int key = list[i];
                int j = i - 1;

                while (j >= 0 && list[j] > key) {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
        }
    



        public static void Quicksort(List<int> list, int lower, int upper){
            int templower = lower;
            int tempupper = upper;
            int pivot = list[(lower+upper)/2];

            while(templower <= tempupper){
                while(list[templower] < pivot){
                    templower++;
                }

                while(list[tempupper] > pivot){
                    tempupper--;
                }

                if(templower <= tempupper){
                    (list[templower],list[tempupper]) = (list[tempupper],list[templower]);
                    tempupper--;
                    templower++;
                }
            }

            if(lower > templower){
                Quicksort(list,lower,templower);
            }
            if(upper < tempupper){
                Quicksort(list,tempupper,upper);
         
            }
        }

    }


}



