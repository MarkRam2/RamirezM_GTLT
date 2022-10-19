// mark ramirez
// 10/18/2022
// greater than less then
// you give me two numbers and I tell you if they are greater than lees than or equal too


Console.Clear();

double idk=0;
bool validation = true;
string num1 = "";
bool playing = true;

while(playing == true)
{

Console.WriteLine("Today we are going to see if one number is greater than or less then the other.");

while(validation == true){
Console.WriteLine("Please enter the first number");

num1 = Console.ReadLine();
    bool NuM1 = Double.TryParse(num1, out idk);
    if(NuM1 == true ){
        validation = false;
    }else if(NuM1 == false){
    }
}

string num2 = "";
validation = true;

while(validation == true){
Console.WriteLine("Please enter number two");

num2 = Console.ReadLine();
    bool NuM1 = Double.TryParse(num2, out idk);
    if(NuM1 == true ){
        validation = false;
    }else if(NuM1 == false){
    }
}

int Numb1 = Convert.ToInt32(num1);
int Numb2 = Convert.ToInt32(num2);

Console.WriteLine("thank you for your coperation");

if(Numb1 == Numb2){
    Console.WriteLine("number one is equal to number two.");
}else if(Numb1 > Numb2){
    Console.WriteLine("number one is greater than number two.");
}else if(Numb1 < Numb2){
    Console.WriteLine("number one is less than number two.");
}

if(Numb2 == Numb1){
    Console.WriteLine("number two is equal to number one.");
}else if(Numb2 > Numb1){
    Console.WriteLine("number two is greater than number one.");
}else if(Numb2 < Numb1){
    Console.WriteLine("number two is less than number one.");
}

bool yessir = true;
Console.WriteLine($"want to play again");
string responce = Console.ReadLine();
while(yessir == true)
{
responce.ToLower();
if(responce == "yes" ){
yessir = false;
playing = true;
}else if(responce == "no" ){
yessir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}