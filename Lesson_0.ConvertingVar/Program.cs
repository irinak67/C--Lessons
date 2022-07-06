// See https://aka.ms/new-console-template for more information

//implicit cast   
//byte b = 42;    // from 0 to 255
//int i = b;      // from -2M to 2M

////explicit cast
//int i = 5;
//int j = 2048;
////byte b = i;       // fail
//byte b = (byte)i;
//byte bb = (byte)j;  // bb = 0
//bool val = true;
//string s = val;

////explicit conversion
//string s = "2048";
////int jojo = (int)s;      //fail
//int iii = Convert.ToInt32(s);
//int ii = int.Parse(s);

//implicit conversion
int i = 1;
string s = "str" + i;

bool val = true;
string ss = val.ToString();

string s1 = "false";
bool val1 = Convert.ToBoolean(s1);

if(Int32.TryParse("123", out int result))
{
    Console.WriteLine(result);
}


Console.WriteLine(s1);