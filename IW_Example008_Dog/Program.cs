int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
Boolean friend = true; 
double time = 0;

while(distance > 10)
{
  if(friend == false)
  {
    time = distance / (firstFriendSpeed + dogSpeed);
    friend = true;
  }
  else
  {
    time = distance / (secondFriendSpeed + dogSpeed);
    friend = false;
  }
  
  distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
  count++;
}

Console.WriteLine(count);