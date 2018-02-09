using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****
 * 
 * 
Enum advantages:
With an enum, magic constants are separate
Modular design makes things easier to understand
Fewer bugs will be introduced.

Tip:
Enums can be used with IntelliSense in Visual Studio. 
This feature will guess the value you are typing.
Press tab:
We can simply press tab and select the enum type we want. 
This is an advantage to using enum types.

***/


namespace DataStructures_InPractice.Enum
{
    public enum ApplicationStatus
    {
        Approved,
        Rejected,
        InDiscussion,
        KeepInView,
        Critical
    }

    public class EnumPractice
    {
        public void enumtest()
        {
            ApplicationStatus status = ApplicationStatus.Approved;
            
            if(status == ApplicationStatus.Approved)
            {
                Console.WriteLine("Application approved");
            }
        }
    }

}
