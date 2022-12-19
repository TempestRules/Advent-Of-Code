package Day_5;

import java.util.ArrayList;

public class Day_5 {

    public static void main(String args[]) {

        FileReader fileReader = new FileReader();

        ArrayList<String> moves = fileReader.getMoves();

        Warehouse warehouse = new Warehouse();

        for (String move: moves) {
            String[] split = move.split(" ");

            int amount = Integer.parseInt(split[1]);
            int from = Integer.parseInt(split[3]);
            int to = Integer.parseInt(split[5]);

            for (int i = 1; i <= amount; i++) {
                String box = warehouse.getStack(from).remove(0);
                warehouse.getStack(to).add(0, box);
            }
        }

        String message = "";
        message += warehouse.getStack(1).get(0).charAt(0);
        message += warehouse.getStack(2).get(0).charAt(0);
        message += warehouse.getStack(3).get(0).charAt(0);
        message += warehouse.getStack(4).get(0).charAt(0);
        message += warehouse.getStack(5).get(0).charAt(0);
        message += warehouse.getStack(6).get(0).charAt(0);
        message += warehouse.getStack(7).get(0).charAt(0);
        message += warehouse.getStack(8).get(0).charAt(0);
        message += warehouse.getStack(9).get(0).charAt(0);

        System.out.println("Message: " + message);

        //Part two
        moves = fileReader.getMoves();

        warehouse = new Warehouse();

        for (String move: moves) {
            String[] split = move.split(" ");

            int amount = Integer.parseInt(split[1]);
            int from = Integer.parseInt(split[3]);
            int to = Integer.parseInt(split[5]);

            if (amount == 1) {
                String box = warehouse.getStack(from).remove(0);
                warehouse.getStack(to).add(0, box);
            } else {
                String boxes = "";
                for (int i = 1; i <= amount; i++) {
                    boxes += warehouse.getStack(from).remove(0);
                }

                String[] boxSplit = boxes.split("");
                for (int i = boxSplit.length - 1; i >= 0; i--) {
                    warehouse.getStack(to).add(0, boxSplit[i]);
                }
            }
        }

        message = "";
        message += warehouse.getStack(1).get(0).charAt(0);
        message += warehouse.getStack(2).get(0).charAt(0);
        message += warehouse.getStack(3).get(0).charAt(0);
        message += warehouse.getStack(4).get(0).charAt(0);
        message += warehouse.getStack(5).get(0).charAt(0);
        message += warehouse.getStack(6).get(0).charAt(0);
        message += warehouse.getStack(7).get(0).charAt(0);
        message += warehouse.getStack(8).get(0).charAt(0);
        message += warehouse.getStack(9).get(0).charAt(0);

        System.out.println("Message 2: " + message);
    }
}
