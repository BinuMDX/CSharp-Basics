﻿string[] orderIds = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(string ids in orderIds){
   if(ids.StartsWith("B")){
    Console.WriteLine(ids);
    }
}

