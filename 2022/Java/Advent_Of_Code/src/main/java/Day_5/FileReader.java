package Day_5;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class FileReader {

    public ArrayList<String> getMoves() {

        ArrayList<String> moves = new ArrayList<>();

        try {
            File myObj = new File("src/main/java/Day_5/Input.txt");
            Scanner myReader = new Scanner(myObj);
            while (myReader.hasNextLine()) {
                String data = myReader.nextLine();
                if (!data.contains("[") && !data.contains(" 1   2   3   4   5   6   7   8   9") && !data.equals("")) {
                    moves.add(data);
                }
            }
            myReader.close();
        } catch (FileNotFoundException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
        return moves;
    }
}
