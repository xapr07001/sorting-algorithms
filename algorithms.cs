


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
        
        public static List<int> Mergesort(List<int> numbers){
            List<int> left;
            List<int> right;
            List<int> results = new List<int>{numbers.Count-1};

            if(numbers.Count-1 <= 1){
                return numbers;
            }
            int mid = numbers.Count-1/2;
            left = new List<int>{mid};

            if(numbers.Count-1 % 2 == 0){
                right = new List<int>{mid};
            }else{
                right = new List<int>{mid+1};
            }
            
            for(int i = 0; i<mid; i++){
                left[i] = numbers[i];
            }


            int x = 0;

            for(int i = mid; i < numbers.Count-1; i++)
            {
                right[x] = numbers[i];
                x++;
            } 
            left = Mergesort(left);
            right = Mergesort(right);
            results = Merge(left,right);
            return results;

        }
        public static List<int> Merge(List<int> left, List<int> right){
            int length = left.Count-1 + right.Count-1;
            List<int> result = new List<int>{length};
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Count-1 || indexRight < right.Count-1){
                if (indexLeft < left.Count-1 && indexRight < right.Count-1){  
                    if (left[indexLeft] <= right[indexRight]){
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else{
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }else if (indexLeft < left.Count-1){
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }else if (indexRight < right.Count-1){
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }  
            }
            return result;
        }
    } 

}
