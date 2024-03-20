using System;
using System.Collections.Generic;

namespace Groups.Implementions
{
    public class GroupManagerEntity
    {
        private Dictionary<string, GroupEntity> _groups;

        public GroupManagerEntity()
        {
            _groups = new Dictionary<string, GroupEntity>();
        }

        // Метод для створення нової групи
        public void CreateGroup(string groupName)
        {
            if (!_groups.ContainsKey(groupName))
            {
                GroupEntity newGroup = new GroupEntity(groupName);
                _groups.Add(groupName, newGroup);
                Console.WriteLine($"Group '{groupName}' created successfully.");
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' already exists.");
            }
        }

        // Метод для видалення групи
        public void RemoveGroup(string groupName)
        {
            if (_groups.ContainsKey(groupName))
            {
                _groups.Remove(groupName);
                Console.WriteLine($"Group '{groupName}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' does not exist.");
            }
        }

        // Метод для додавання студента до групи
        public void AddMemberToGroup(string groupName)
        {
            if (_groups.ContainsKey(groupName))
            {
                _groups[groupName].AddMemberAtomically();
                Console.WriteLine($"Member added to group '{groupName}'.");
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' does not exist.");
            }
        }

        // Метод для видалення студента з групи
        public void RemoveMemberFromGroup(string groupName)
        {
            if (_groups.ContainsKey(groupName))
            {
                _groups[groupName].RemoveMemberAtomically();
                Console.WriteLine($"Member removed from group '{groupName}'.");
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' does not exist.");
            }
        }

        // Метод для виведення кількості членів у групі
        public void PrintGroupMemberCount(string groupName)
        {
            if (_groups.ContainsKey(groupName))
            {
                _groups[groupName].PrintMemberCount();
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' does not exist.");
            }
        }
    }
}
