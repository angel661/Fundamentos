/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sudoku;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author Hp
 */
public class auxiliar {
    static int m[][]=new int[9][9];
    static List < Integer > num = new ArrayList < Integer > ();

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner x=new Scanner(System.in);
//         TODO code application logic here
//                generar();
        cargar();
        for(int i=0; i<9; i++){
            int j=0;
            while(j<9){
//                int numero = ;
                cargarlista(i,j);
                int numero = generar();
//                int numero=x.nextInt();
//                System.out.println(numero);
//                if(comprobar(numero,i,j)){
                    m[i][j]=numero;
                    j++;
//                }
                imprimir();
            }
        }
//        imprimir();
    }
//    public static boolean comprobar(int numero, int fila, int columna){
//        boolean estado=true;
//        for(int i=0; i<columna; i++){
//            if(numero==m[fila][i]){
//                estado=false;
//            }
//        }
//        for(int i=0; i<fila; i++){
//            if(numero==m[i][columna]){
//                estado=false;
//            }
//        }
//        return estado;
//    }
    public static void imprimir(){
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                System.out.print(m[i][j]+" ");
            }
            System.out.println();
        }
    }
    public static void cargar(){
        for(int i=0; i<18; i++){
            num.add(0);
        }
    }
    public static void cargarlista(int fila, int columna){
        for(int i=0; i<9; i++){
            num.set(i, m[fila][i]);
        }
        for(int i=0; i<9; i++){
            num.set(9+i, m[i][columna]);
        }
        
        for(int i=0; i<18; i++){
            System.out.print(num.get(i));
        }
    }
    public static int generar(){    
        int pos;
        int nCartas = 9;
          pos = (int) Math.floor(Math.random() * nCartas +1);
          while (num.contains(pos)) {
            pos = (int) Math.floor(Math.random() * nCartas+1 );
          }
        return pos;
    }
//    public static void generar(){    
//        int pos;
//        int nCartas = 9;
//        List < Integer > pCartas = new ArrayList < Integer > ();
//        for (int i = 0; i < nCartas ; i++) {
//          pos = (int) Math.floor(Math.random() * nCartas +1);
//          while (pCartas.contains(pos)) {
//            pos = (int) Math.floor(Math.random() * nCartas+1 );
//          }
//          pCartas.add(pos);
//        }
//        System.out.println("Núm. aleatorios sin repetición:");
//        System.out.println(pCartas.toString());
//    }
}
