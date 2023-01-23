string[] arraygiven = new string [8] {"yesterday", "all", "my", "troubles", "seemed", "so", "far", "away"};
string[] arrayresulting = new string [arraygiven.Length];
void ResultArray (string[] arraygiven, string[] arrayresulting){
    int count = 0;
    for (int i=0; i<arraygiven.Length; i++){
        if (arraygiven[i].Length<=3){
        arrayresulting[count] = arraygiven[i];
        count++;
        }        
    }
}
void ShowResultArray (string[] arrayresulting){
    for (int i=0; i<arrayresulting.Length; i++){
        Console.Write($"{arrayresulting[i]} ");
    }
}
ResultArray (arraygiven, arrayresulting);
ShowResultArray (arrayresulting);
