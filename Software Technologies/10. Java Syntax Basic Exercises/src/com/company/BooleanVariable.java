package com.company;

import java.util.Scanner;

public class BooleanVariable {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Boolean bool = Boolean.parseBoolean(scanner.nextLine());

        if(bool){
            System.out.print("Yes");
        } else {
            System.out.print("No");
        }
    }
}
