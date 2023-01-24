using System.Diagnostics;

Stopwatch st= new Stopwatch();

st.Start();
Console.WriteLine(fib(20)); // первый номер



st.Stop();
Console.WriteLine( $"Ticks: {st.ElapsedTicks}"); //для 5-(79127) ,10-(88414)  ,20-(88701)

st.Restart();


int  cf=20;
int a =0;
int z=1;
st.Start();
for (int i =0 ;i<cf;i++)
{
    int t=a;
    a=z;
    z=t+z;  


}

st.Stop();
Console.WriteLine( $"Ticks: {st.ElapsedTicks}");//для 5-(2) ,10-(2)  ,20-(2)






int  fib(int num)
    {
        if (num<=1)
        {
            return 1;
        }
        return fib(num-1)+fib(num-2);
    }