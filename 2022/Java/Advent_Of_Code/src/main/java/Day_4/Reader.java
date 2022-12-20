package Day_4;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class Reader {

    public ArrayList<Ranges> getRanges() {

        ArrayList<Ranges> ranges = new ArrayList<>();

        try {
            File myObj = new File("src/main/java/Day_4/Input.txt");
            Scanner myReader = new Scanner(myObj);
            while (myReader.hasNextLine()) {
                String data = myReader.nextLine();
                String[] rangeGroups = data.split(",");
                String rangeGroup1 = rangeGroups[0].toString();
                String rangeGroup2 = rangeGroups[1].toString();

                String[] firstRanges = rangeGroup1.split("-");
                String[] secondRanges = rangeGroup2.split("-");

                Ranges range = new Ranges(
                        Integer.parseInt(firstRanges[0]),
                        Integer.parseInt(firstRanges[1]),
                        Integer.parseInt(secondRanges[0]),
                        Integer.parseInt(secondRanges[1])
                );

                ranges.add(range);
            }
            myReader.close();
        } catch (FileNotFoundException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
        return ranges;
    }
}
