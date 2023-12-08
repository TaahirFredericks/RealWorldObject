namespace Assignment3_CreateARealWordsC_Class_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            {
                
                RealWorldClassTelevsion myTV = new RealWorldClassTelevsion(); //turning my class into a "new" RealWorldClassTelevi
                

               
                myTV.TurnOn(); //the methods that are used to operate the TV
                myTV.ChangeVolume(19);
                myTV.ChangeChannel(5);
                myTV.DisplayTVInfo();

                //myTV.TurnOff();
            }
        }
    }
    
}
