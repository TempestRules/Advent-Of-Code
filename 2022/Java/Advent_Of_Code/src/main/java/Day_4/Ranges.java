package Day_4;

import java.util.ArrayList;

public class Ranges {

    private int range1;
    private int range2;

    private int range3;
    private int range4;

    public Ranges(int range1, int range2, int range3, int range4) {
        this.range1 = range1;
        this.range2 = range2;
        this.range3 = range3;
        this.range4 = range4;
    }

    public boolean containsRangesFully() {
        //First range in the second
        if (range1 >= range3 && range2 <= range4) {
            return true;
            //Second range in the first
        } else if (range3 >= range1 && range4 <= range2) {
            return true;
        }
        return false;
    }

    public boolean anyOverlap() {
        ArrayList<Integer> firstPair = new ArrayList<>();
        ArrayList<Integer> secondPair = new ArrayList<>();

        for (int i = range1; i <= range2; i++) {
            firstPair.add(i);
        }
        for (int i = range3; i <= range4; i++) {
            secondPair.add(i);
        }

        for (int section: firstPair) {
            if (secondPair.contains(section)) {
                return true;
            }
        }

        return false;
    }
}
