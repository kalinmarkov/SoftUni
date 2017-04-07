package com.company;

import java.util.Scanner;

public class VariableInHexFormat {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String variableInHex = scanner.next();

        int number = Integer.parseInt(variableInHex, 16);

        System.out.println(number);
    }
}
