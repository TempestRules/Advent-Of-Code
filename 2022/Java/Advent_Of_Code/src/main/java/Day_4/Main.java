package Day_4;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        Reader reader = new Reader();
        ArrayList<Ranges> ranges = reader.getRanges();

        int pairCounter = 0;

        for (Ranges range: ranges) {
            if (range.containsRangesFully()) {
                pairCounter++;
            }
        }

        System.out.println("There are: " + pairCounter + " pairs where one range fully contains the other");

        //Part two
        pairCounter = 0;

        for (Ranges range: ranges) {
            if (range.anyOverlap()) {
                pairCounter++;
            }
        }

        System.out.println("There are: " + pairCounter + " pairs with overlap");
    }
}
