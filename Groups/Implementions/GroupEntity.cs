using System;
using System.Threading;

namespace Groups.Implementions
{
    public class GroupEntity
    {
        private string _groupName;
        private int _memberCount;

        public GroupEntity(string groupName)
        {
            _groupName = groupName;
            _memberCount = 0;
        }

        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        public int MemberCount
        {
            get { return _memberCount; }
        }

        // Атомарна функція для додавання члена групи
        public void AddMemberAtomically()
        {
            Interlocked.Increment(ref _memberCount);
        }

        // Атомарна функція для видалення члена групи
        public void RemoveMemberAtomically()
        {
            Interlocked.Decrement(ref _memberCount);
        }

        public void PrintMemberCount()
        {
            Console.WriteLine($"Current member count in group {_groupName}: {_memberCount}");
        }
    }
}

