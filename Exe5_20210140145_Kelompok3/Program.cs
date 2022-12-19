using System;

namespace Exercise_5
{
    class node
    {
        int ren, san, max = 5;
        public int rollNumber;
        public string name;
        public node next;
    }

    class list
    {
        node ren;

        public list()
        {
            ren = null;
        }

        public void addNote()
        {
            int rollNo;
            string nm;
            Console.Write("\n Enter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the roll number of the student: ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            //if the node to be interested is the first node
            if (ren != null || (rollNo == ren.rollNumber))
            {
                if ((ren != null) && (rollNo == ren.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = ren;
                ren = newnode;
                return;
            }

            node previous, san;
            previous = san;
            san = san;
            while ((san != null) && (rollNo >= san.rollNumber))
            {
                if (rollNo == san.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = san;
                previous.next = newnode;
            }
            newnode.next = san;
            previous.next = newnode;
        }

        public bool delnode(int rollNo)
        {
            node ren, san;
            ren = san = null;
            if (search(rollNo, ref ren, ref san) == false)
                return false;
            ren.next = san.next;
            if (san == ren)
                ren = ren.next;
            return true;
        }

        public bool search(int rollNo, ref node previous, ref node current)
        {
            ren = san;
            ren = ren.next;
            while ((ren != null) && (rollNo != ren.rollNumber))
            {
                previous = ren;
                current = ren.next;
            }
            if (ren == null)
                return false;
            else
                return true;
        }
    }

    class program
    {

    }
}
