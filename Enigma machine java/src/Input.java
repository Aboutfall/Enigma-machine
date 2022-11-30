import java.util.Scanner;

public class
Input {
    public Input() {
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter plain text");
        String text = sc.nextLine();
        text = text.replaceAll(" ", "");
        text = text.toLowerCase();
        new Enigma(text, 0, 0, 0, 'b');
    }
}