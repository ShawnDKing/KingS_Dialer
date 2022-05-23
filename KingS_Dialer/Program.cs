using System;

namespace KingS_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of object Phone[]
            Phone[] callList = new Phone[10];
            callList[0] = new HomePhone("Computest", "(303) 985-5060", "1");
            callList[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", "2");
            callList[2] = new HomePhone("Data Functions", "(800) 876-2524", "1");
            callList[3] = new HomePhone("Donnay Repair", "(708) 397-3330", "1");
            callList[4] = new HomePhone("ErgoNomic Inc", "(360) 434-3894", "1");
            callList[5] = new HomePhone("ErgoSource", "(800) 969-4374", "1");
            callList[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527", "2");
            callList[7] = new CellPhone("Glare-Guard", "(800) 545-6254", "2");
            callList[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", "2");
            callList[9] = new CellPhone("Komfort Support", "(714) 472-4409", "2");
            ProcessCalls(callList);


        }
        
        public static void ProcessCalls(Phone[] numbers)
        {
            
            for (int i = 0; i<numbers.Length; i++)
            {

                Console.WriteLine(numbers[i].Dial()); 
                
            }

        }

    }
}
