package Day_5;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class Warehouse {

    private Map<Integer, ArrayList<String>> warehouse = new HashMap<>();
    private ArrayList<String> stack1 = new ArrayList<>();
    private ArrayList<String> stack2 = new ArrayList<>();
    private ArrayList<String> stack3 = new ArrayList<>();
    private ArrayList<String> stack4 = new ArrayList<>();
    private ArrayList<String> stack5 = new ArrayList<>();
    private ArrayList<String> stack6 = new ArrayList<>();
    private ArrayList<String> stack7 = new ArrayList<>();
    private ArrayList<String> stack8 = new ArrayList<>();
    private ArrayList<String> stack9 = new ArrayList<>();

    public Warehouse() {
        //Stack1
        stack1.add("F");
        stack1.add("H");
        stack1.add("M");
        stack1.add("T");
        stack1.add("V");
        stack1.add("L");
        stack1.add("D");

        //Stack2
        stack2.add("P");
        stack2.add("N");
        stack2.add("T");
        stack2.add("C");
        stack2.add("J");
        stack2.add("G");
        stack2.add("Q");
        stack2.add("H");

        //Stack3
        stack3.add("H");
        stack3.add("P");
        stack3.add("M");
        stack3.add("D");
        stack3.add("S");
        stack3.add("R");

        //Stack4
        stack4.add("F");
        stack4.add("V");
        stack4.add("B");
        stack4.add("L");

        //Stack5
        stack5.add("Q");
        stack5.add("L");
        stack5.add("G");
        stack5.add("H");
        stack5.add("N");

        //Stack6
        stack6.add("P");
        stack6.add("M");
        stack6.add("R");
        stack6.add("G");
        stack6.add("D");
        stack6.add("B");
        stack6.add("W");

        //Stack7
        stack7.add("Q");
        stack7.add("L");
        stack7.add("H");
        stack7.add("C");
        stack7.add("R");
        stack7.add("N");
        stack7.add("M");
        stack7.add("G");

        //Stack8
        stack8.add("W");
        stack8.add("L");
        stack8.add("C");

        //Stack9
        stack9.add("T");
        stack9.add("M");
        stack9.add("Z");
        stack9.add("J");
        stack9.add("Q");
        stack9.add("L");
        stack9.add("D");
        stack9.add("R");

        warehouse.put(1, stack1);
        warehouse.put(2, stack2);
        warehouse.put(3, stack3);
        warehouse.put(4, stack4);
        warehouse.put(5, stack5);
        warehouse.put(6, stack6);
        warehouse.put(7, stack7);
        warehouse.put(8, stack8);
        warehouse.put(9, stack9);
    }

    public ArrayList<String> getStack(int stack) {
        return warehouse.get(stack);
    }
}