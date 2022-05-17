﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace CSharp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";
            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('z');
            // 2. 변형
            name = name + " Junior";
            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();
            string newName = name.Replace('r', 'l');

            // 3. 분할
            string[] names = name.Split(new char[] {' '});
            string substrName = name.Substring(5);
        }
    }
}