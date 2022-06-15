void (int[] reverseIt(int index , int [] main_Arr))
{
    if(index==(main_Arr.length)/2)
    {
      return main_Arr;
    }

    int a =main_Arr[(main_Arr.length-1)%index];
    int b =main_Arr[index];
    main_Arr[(main_Arr.length-1)%index]=b;
    main_Arr[index]=a;
    reverseIt(index-1, main_Arr);
    return main_Arr;
}
