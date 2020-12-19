/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sudoku;

import java.util.Scanner;

/**
 *
 * @author Hp
 */
public class Sudoku {
    
    public int [][] generarInicial(int inicial[][]){
        Scanner x=new Scanner(System.in);
        for(int i=0; i<9; i++){
            for(int j=0;j<9;j++){
                inicial[i][j]=x.nextInt();
            }
        }
        return inicial;
    }
    public int [][] generarPartida(int partida[][]){
        for(int i=0; i<9; i++){
            for(int j=0;j<9;j++){
                if((int)(Math.random()*8)==j){
                    partida[i][j]=0;
                }
                if((int)(Math.random()*8)==j){
                    partida[i][j]=0;
                }
            }
        }
        return partida;
    }
    public boolean terminado(int partida[][]){
        boolean estado=true;
        for(int i=0; i<9; i++){
            for(int j=0; j<9; j++){
                if(0==partida[i][j]){
                    estado=false;
                }
            }
        }
        return estado;
    }
    public boolean comprobardato(int partida[][], int numero, int fila, int columna){
        boolean estado=true;
        for(int i=0; i<9; i++){
            if(numero==partida[fila][i]){
                estado=false;
            }
        }
        for(int i=0; i<9; i++){
            if(numero==partida[i][columna]){
                estado=false;
            }
        }
        
        /********************************************************************/
        if(fila>=0 && fila<=2 && columna>=0 && columna<=2){
            for(int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=0 && fila<=2 && columna>=3 && columna<=5){
            for(int i=0; i<3; i++){
                for(int j=3; j<6; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=0 && fila<=2 && columna>=6 && columna<=8){
            for(int i=0; i<3; i++){
                for(int j=6; j<9; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=3 && fila<=5 && columna>=0 && columna<=2){
            for(int i=3; i<6; i++){
                for(int j=0; j<3; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=3 && fila<=5 && columna>=3 && columna<=5){
            for(int i=3; i<6; i++){
                for(int j=3; j<6; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=3 && fila<=5 && columna>=6 && columna<=8){
            for(int i=3; i<6; i++){
                for(int j=6; j<9; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=6 && fila<=8 && columna>=0 && columna<=2){
            for(int i=6; i<9; i++){
                for(int j=0; j<3; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=6 && fila<=8 && columna>=3 && columna<=5){
            for(int i=6; i<9; i++){
                for(int j=3; j<6; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        if(fila>=6 && fila<=8 && columna>=6 && columna<=8){
            for(int i=6; i<9; i++){
                for(int j=6; j<9; j++){
                    if(numero==partida[i][j]){
                        estado=false;
                    }
                }
            }
        }
        return estado;
    }
   
    public void imprimir(int m[][]){
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                System.out.print(m[i][j]+" ");
            }
            System.out.println();
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
//    public static void generarMatriz(){
//        for(int i=0; i<3; i++){
//            int j=0;
//            while(j<3){
//                 int numero = (int)(Math.random()*9+1);
//                 if(comprobar(numero,i,j)){
//                     m[i][j]=numero;
//                     j++;
//                 }
//             }
//        }
////                 imprimir();
//    }
//    public static boolean comprobar(int numero, int fila, int columna){
//        boolean estado=true;
//        
//        //matriz de 3x3
//        for(int i=0; i<3; i++){
//            if(numero==m[fila][i]){
//                estado=false;
//            }
//        }
//        for(int i=0; i<3; i++){
//            if(numero==m[i][columna]){
//                estado=false;
//            }
//        }
//        for(int i=0; i<3; i++){
//            for(int j=0; j<3; j++){
//                if(numero==m[i][j]){
//                    estado=false;
//                }
//            }
//        }
//        //matriz de 9x9
//        for(int i=0; i<9; i++){
//            if(numero==m[fila][i]){
//                estado=false;
//            }
//        }
//        for(int i=0; i<9; i++){
//            if(numero==m[i][columna]){
//                estado=false;
//            }
//        }
//        
//        return estado;
//    }
//    public static void imprimir(){
//        for(int i=0;i<9;i++){
//            for(int j=0;j<9;j++){
//                System.out.print(m[i][j]+" ");
//            }
//            System.out.println();
//        }
//    }
    
}
