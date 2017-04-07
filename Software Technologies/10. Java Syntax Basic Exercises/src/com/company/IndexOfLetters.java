package com.company;

import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String str = scanner.nextLine();

        for(int i = 0; i < str.length(); i++){
            System.out.println(str.charAt(i) + " -> " + (str.charAt(i) - 'a'));
        }
    }
}
