
namespace Array {

class Program {

static void Repeat(String s , int number) {
if (number!=0) {
System.Console.WriteLine(s);
number--;
Repeat(s,number);
}
}

static int MaxValue(int i, int x){
int max = 0;
if (i > x){
 max = i;
} else 
max = x;
return max;
}

 static int  MaxValue(int b, int c,int a){
int max = 0;

if (b > c & b > a){
     max = b;
}
else if (c > b & c >a){
     max = c;
}
else {
     max = a;
}
return max;

}
 
 static int  MaxValue(int b, int c,int a,int t){
     int max = 0;
if ( (b > c & b > a & b >t)  ){
     max = b;
}
else if ( (c > b & c > a & c >t)  ){
     max = c;
}
else if ( (a > b & a > c & a >t)  ){
     max = a;
}
else max = t;

return max;

}

static int MinValue (int a,int b,int c){
int min = 0;

if (a < b & a < c ){
     min  = a;
}
else if (b < a & b < c  ){
     min  = b;
}
else if (c < a & c < b){
     min  = c;
}
return min;

}

 static int MinValue (int a,int b,int c,int t){
int min = 0;

if (a < b & a < c & a<t){
     min  = a;
}
else if (b < a & b < c & b < t ){
     min  = b;
}

else if (c < a & c < b & c < t ){
     min  = c;
}

else {
     min = t;
}
return min;
}

static bool TrySumifOdd (int a, int b){
int sum = 0;
sum = a + b;

if ( (sum%2)!=0 ){
     return true;
}

return false;
}


     public static void Main (){

          int max = MaxValue(6,1,2,3);
          int min = MinValue(20,50,10);
          bool odd = TrySumifOdd(2,3);

          Repeat("str",3);

          System.Console.WriteLine(odd);

          System.Console.WriteLine(min);


       
               }
     }
}

