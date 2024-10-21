char[,] gameboard = new char[,]{{'-','-','-'}, {'-','-','-'}, {'-','-','-'}};
bool win = false;
bool player = false;
while(!win){

    Play(ref player);
    player = !player;

    for(int x = 0; x < gameboard.GetLength(0);x++){
    for(int y = 0; y < gameboard.GetLength(1);y++){
        Console.Write(gameboard[x,y]);
        }
    Console.WriteLine();
    }
    win = WinCheck();
}
if(player){
    Console.WriteLine("Player 1 Wins");
}else{
    Console.WriteLine("Player 2 wins");
}

bool WinCheck(){
    return Winx() || Winy() || WinDiagonal();
}

bool Winx(){
    for(int m = 0;m <= 2; m++){
        if(gameboard[0, m] ==  '-'){
            continue;
        }
        if(gameboard[0, m] == gameboard[1, m] && gameboard[1, m] == gameboard[2, m]){
            return true;
        }
    }
    return false;
}
bool Winy(){
    for(int m = 0;m <= 2; m++){
        if(gameboard[m, 0] ==  '-'){
            continue;
        }
        if(gameboard[m, 0] == gameboard[m, 1] && gameboard[m, 1] == gameboard[m, 2]){
            return true;
        }
    }
    return false;
}
bool WinDiagonal(){
    if(gameboard[1, 1] == '-' ){
        return false;
    }


    if(gameboard[0, 0] == gameboard[1, 1] && gameboard[1, 1] == gameboard[2, 2]){
        return true;
    }else if(gameboard[0, 2] == gameboard[1, 1] && gameboard[1, 1] == gameboard[2, 0]){
        return true;
    }
    return false;
}
void Play(ref bool p){
    char ox;
    if(p){
        ox = 'x';
    }else{
        ox = 'o';
    }
    
    Console.WriteLine("Ange...");
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine("Ange...");
    int a = int.Parse(Console.ReadLine());



    if(gameboard[a-1,b-1] == '-'){
        gameboard[a-1,b-1] = ox;
    }else{
        Console.WriteLine("not possible");
        p = !p;
    }
}
