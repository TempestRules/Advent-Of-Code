package Day_8;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        Reader reader = new Reader();
        ArrayList<String> forest = reader.getMoves();

        int rowCounter = 0;
        int treeCounter = 0;

        for (String s: forest) {
            String[] row = s.split("");

            for (int i = 0; i < row.length; i++) {

                if (shorterAbove(i, rowCounter, forest, row) ||
                    shorterBelow(i, rowCounter, forest, row) ||
                    shorterLeft(i, row) ||
                    shorterRight(i, row)) {

                    treeCounter++;
                }
            }
            rowCounter++;
        }

        System.out.println("There are: " + treeCounter + " visible trees");

        //Part two
        rowCounter = 0;
        int highScore = 0;

        for (String s: forest) {
            String[] row = s.split("");

            for (int i = 0; i < row.length; i++) {

                int currentScore =
                        scoreAbove(i, rowCounter, forest, row) *
                        scoreBelow(i, rowCounter, forest, row) *
                        scoreLeft(i, row) *
                        scoreRight(i, row);

                if (currentScore > highScore) {
                    highScore = currentScore;
                }
            }
            rowCounter++;
        }

        System.out.println("The highest possible score is: " + highScore);
    }

    public static boolean shorterAbove(int tree, int rowNumber, ArrayList<String> forest, String[] currentRow) {
        for (int i = rowNumber - 1; i >= 0; i--) {
            String[] rowAbove = forest.get(i).split("");
            if (Integer.parseInt(rowAbove[tree]) >= Integer.parseInt(currentRow[tree])) {
                return false;
            }
        }
        return true;
    }

    public static int scoreAbove(int tree, int rowNumber, ArrayList<String> forest, String[] currentRow) {
        int score = 0;
        for (int i = rowNumber - 1; i >= 0; i--) {
            String[] rowAbove = forest.get(i).split("");
            if (Integer.parseInt(rowAbove[tree]) >= Integer.parseInt(currentRow[tree])) {
                score++;
                break;
            }
            score++;
        }
        return score;
    }

    public static boolean shorterBelow(int tree, int rowNumber, ArrayList<String> forest, String[] currentRow) {
        for (int i = rowNumber + 1; i < forest.size(); i++) {
            String[] rowBelow = forest.get(i).split("");
            if (Integer.parseInt(rowBelow[tree]) >= Integer.parseInt(currentRow[tree])) {
                return false;
            }
        }
        return true;
    }

    public static int scoreBelow(int tree, int rowNumber, ArrayList<String> forest, String[] currentRow) {
        int score = 0;
        for (int i = rowNumber + 1; i < forest.size(); i++) {
            String[] rowBelow = forest.get(i).split("");
            if (Integer.parseInt(rowBelow[tree]) >= Integer.parseInt(currentRow[tree])) {
                score++;
                break;
            }
            score++;
        }
        return score;
    }

    public static boolean shorterLeft(int tree, String[] currentRow) {
        for (int i = tree - 1; i >= 0; i--) {
            if (Integer.parseInt(currentRow[i]) >= Integer.parseInt(currentRow[tree])) {
                return false;
            }
        }
        return true;
    }

    public static int scoreLeft(int tree, String[] currentRow) {
        int score = 0;
        for (int i = tree - 1; i >= 0; i--) {
            if (Integer.parseInt(currentRow[i]) >= Integer.parseInt(currentRow[tree])) {
                score++;
                break;
            }
            score++;
        }
        return score;
    }

    public static boolean shorterRight(int tree, String[] currentRow) {
        for (int i = tree + 1; i < currentRow.length; i++) {
            if (Integer.parseInt(currentRow[i]) >= Integer.parseInt(currentRow[tree])) {
                return false;
            }
        }
        return true;
    }

    public static int scoreRight(int tree, String[] currentRow) {
        int score = 0;
        for (int i = tree + 1; i < currentRow.length; i++) {
            if (Integer.parseInt(currentRow[i]) >= Integer.parseInt(currentRow[tree])) {
                score++;
                break;
            }
            score++;
        }
        return score;
    }
}
