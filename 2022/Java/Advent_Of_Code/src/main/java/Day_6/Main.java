package Day_6;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        String buffer = "gzbzwzjwwrfftfrrbvvcbcvcffpssvhhzfzbfzzrbrtrcttnthnhsnhsnnclcpctpprwwgppppchhvvctvtsvswwcdcrrdzdhzdzvddvfvfjjlldvvfllfhlfhlhghnhghrgrsggvbbhdhffzggmttjqtjjgljjwtjwjggldlzzrfrpppjsjggqrrdbbgwgtwwwtqwtqqvccjnnhrhqqsnssjbssmjjbzjjqnqnlnjncjjzzqddfqqqnqvnqncqqmsshqqccssvpvllbbfvfmmmgzgdggtjgjtjbttngtnnhhfrfddmtmtftcftthvttwzwrzrbrgrbrqbqccmmtvtqvtqqzmzwmzzzsvzvhhhqlhqlqplpggvmvwmmshhnshsjszzljlnlrnllgddqllpmllsgswwqnqlnlqqlmqqvrqvrqrppvrrqwqhqllgjgcggsllqgllghlghhbvhhcvvbddvcvwwwzdzzfjjvcczbbwccjvccmvmfvfgfmfttwrttpmtmsszccjggcssmqsmsgszzfpphghvgvvcddtltwlwnnrbbfdbbtssrvvmwwjfflmlblwlrlmlwwhrhnhqnnvdvllzblzzndzdlzzhpprbrprnrzrjjlnlnrrjddgrrwrttcstsgshszzvgvfvpfpqfpfbpbfbwbmmzvvnnqvvqppzspzpzplldqlqsqlldmlmgmcmwmsmfsfzfdzzbpzzbbcwbbtppphlhshchjjszztctpprqppszzchcqczczddscsrstsntstjsjqjjfggvccgbggqhghrhppdldnlndnpddllgplgppnlpnnmwwglghhftfrtrqtqsszrssfjjzhzfhfssflfslsmmgrrcdrdnrdnnqznndrrbtrrmhrhbhsbsgsnslsqlqnncpccplpldpldppshsdssqdsqdsqdsdsdfsddchczhczcszcscffzhfzffpbbgttdhthnhnjnwnnwrrmwmlljzlzlzdzrrcvcbbsfstfsfnfqftqffgjfjzfjfsjswswccsvcvlccshhjpjcccnfnqqmsqmmrwmwjwswgsgjsjttmjmjttpqtqwttgmgfmmnbnrnpnwppgspggwnwqnqpqmmbmmnwnllbwwdqqzsqqtgttnrtrllcwcchpchcbhbpbnpbpsptpvtvzvrzzslljddjzjjmqmmdpmddcdzzrdrqddtctppwzzwrzrvzrvrzzjtztqqsmmcncllhmlmpmhgsrtrzjhjbtfvhmzpssfbjwcdshthnmmqmfhlhwcbbllwzbwfgfvzjcqblchzqqqgcgmpnbnnblhbcpgmvsbvtcmhsghldlhqlghgtpdvjflmjsmppdsvrjlwvhmwsmfvvdnzpmtfqjqpjdctnnrlfjfvdtmvdmhsczlfsqwfrqtlqwnzdzrcdzmhvrgwnjjtqjrqljhgcffglvhnsdssqdpfrfhtjwlqzvfjmpjnqhsjvndtstqjsqgcmgqdjvfqnlmtjlvcblndprmffrgqdnnncnlfflclgqbjbmsdqsjrmzpwtbqqqqsqmgthhjfqwzvcbqwlvdbffhcvncpldmchnptbnlbhmzrrjhzvzdrvtlhsnfnfdnvhlrlrmdcpnmvdwswctcqldszlvftqtwldrhmfjmfvcgjcdjsbjqjwdtslblwhqfvgrfcpnhszqqsfwbwcmvfvccvztdmcjqfjvdvmbdtcjvtwqpwsqjtdvpvvvsdrrvngmjztgjtnpdbmtlrbrjlwsdnthgzgpssgbzzrqvgblqhrtfbflnphvhpzmdfrwqvjjvcpsmdrqwdbzlpnqpmglgqzfhctrzdpzdthqgjtvpwcrlsmqnjwgzlnqbthvfswhjtrrsrswhbmnddgzmznvppbnmtjpzpdpmpzpmsgfstzldgmrtgplwwsbztphtcvdfgsqzqwrmlqpnhvpcqpfjpbrthrtwgqlfnrqcrpvhssjmhfgpnzzvlrlcbnpmddhtdvvfrrvprqrwbhfgvvltgrhrpwsdgvrlgthbztcgcfggtcfzqtlcdhpmcvpgcszslhpfrttnrdrqpqlgdfwtccmbhfrnlbhhmrtrjmzstbqhmtphzcpcllzsnghfvlwvzzvlqrjmfsvhrnjnvldgnbqvpjsmmphhrmhqrtcncmjwbdlqtrvmhgjrjsrddcpqnjhfmczfgwzspnrjfwvfdpdlcfpvctfrlspdwwlnpbvbglzsmgfsmrshsqgcvlfrvjssrglbwvvvgpvtqshbtqmzbnglflhhldtfzqssptrbnnzdqwqtstpftdqgmmhfjdlfwtmcmtmcgcvtfhzvsbllgbchvlhrgnvvbsnrwqrlvdqlcwwlgbjrvrzgcvljqzvdngtbhpnppjrzpmbwztzvnvrbfccfgvnqvrcmpdblngcvlwjwzpbbwmnslsdjmbrwbvnjsgcmsfvzvnwbzrrlzvgdnzcqqgggvmcwczjqnrddnzhlndgzjbvtbtjqdnlvlflqnfvjdmfstpdfqsgjdslgtpgdnvvpmfwvlqbmbgdrqjhdfhlmsdtfwpscsvdzmswszjfwqtsjqpfnjjlnsspvlgzwwtvwgdzfjjljfwbvfbvpglcqcdbdpshwcqzswbwhftbfqblzpqfmqpvzdjsrcqtvjntnhmlhmzllffcjsdnwpfzdglvlrhrljbrhjhgdnfcqcrccwrbbhrvqwrzlwjrrwzsfcwsvbqsjgtgpzqwlczljrtdhtzcgsfgqssdbjjmttdtzhrqtbqjtqfwmcpdftrfjmznpscsqmtfcdpcdjwcqjvmhngcqnmtmwfttcvpwgcnhhgnnbgjdvztzhczvqljjqwcmwcbvmqqjsfnmhtbtsvsnsfwfzgdvlctrgdvbjqpgfrrlsnppmvhfbbclprlvcssnvtsgftmlpqrpjzrrphrzltbtgfwjqqvbgqjdpdgqvzppfzcbhdbbjttcdzclsphtlzfvnfqgpmqvpzrqgpdnbmsrqgsnfdwpvndzmsllgmnrlhnnzldwshtrrsrsmdncwrcjnmcjlwbbfpzcwzvldtgvbcvhnbhgjgwjcvslrfcwbqlrqldvpcgnbwbzzncncftrgbrwchfrrtnpqsjbcpzvplnbqdgtvnnrcwwfvbdzdrsfspvtbhflhsbqmlsjvfmpvjbfvcrdmgrfqsmqgfrntfqnlqbvmsqtpncjrstspbqvfmddmhwsssdcddshmwdlscttmdzljtpwhzhzhwsdnmgjstfmlnqqvzzdqpqsjdsllswmqcjtnthwqnhbscrjdstljqgncjvjvlpfrtscrzrqghrdvdnbtnpshpldcchljzrzqjlwwscnphvrwlvzttcdjdrddgmvqpvdmttdqhwpfmslzvnrwlrrdttbhctgpgzjrmdwjbcmsprwggvmdmmltldgpbfnppnrpwcnpgtblccdvbsnfvgzmjppftvndmdslfshjvndfvvzjjlzhgfmhcggttrcrbrlwrqgjpchvhnjwqnbsnmftwszhzftglrfdvvnbcbzsslgmdchtrrrqqzhllrfhwfwbbdgfpdfwssmzcfcnzmrhfdddtdhfqmctsglqbwhwpnbdzbsfbbvvthrrgjvztjjwgjcgjntrddmmdldtmvjnwjbcqwfwvfhsrpchznhlqpcttqjffbrpbftftdjzlrqchmzrfgjrqlndfwfrghtsfsblcvtjmjrbfrwdgsgzmmjpdlbwzfscfsfcdqwdwnjwjbvvbptmfrqltmnlpbtrqspwdfmhnncqgtrtmbzhfmwrbcqhmmpmvprvwrjplspcmmspldmbgpbtmqjtrfcpfhcnpjbnlhjpzflstjqfqvzcnfgvrmtplndchffzrtfrqdpdnzrspddwmpzlfchrzzfcfvmbvfnlfwtfbvnffdqhljbvwwdtmszgrjtzwqdbgvvfphcnsdgvlmslqngfmsbrztrnpjprghmjffscbnfqwrvjjjtfzrmjtzbwdsmzgmbtjzvddhngmzvflwftblbzfd";
        String[] bufferArr = buffer.split("");

        int markerCounter = 0;
        ArrayList<String> markers = new ArrayList<>();

        for (String s: bufferArr) {

            markerCounter++;

            if (markers.size() < 4) {
                markers.add(s);
            }
            if (markers.size() == 4) {
                if (checkDuplicate(markers)) {
                    markers.remove(0);
                } else {
                    printList(markers);
                    break;
                }
            }
        }

        System.out.println("Markers: " + markerCounter);

        //Part two
        markerCounter = 0;
        markers.clear();

        for (String s: bufferArr) {

            markerCounter++;

            if (markers.size() < 14) {
                markers.add(s);
            }
            if (markers.size() == 14) {
                if (checkDuplicate(markers)) {
                    markers.remove(0);
                } else {
                    printList(markers);
                    break;
                }
            }
        }

        System.out.println("State of the art message markers: " + markerCounter);
    }

    public static void printList(ArrayList<String> list) {
        String print = "";
        for (String s: list) {
            print += s;
        }
        System.out.println(print);
    }
    public static boolean checkDuplicate(ArrayList<String> list) {
        for (int i = 0; i < list.size(); i++) {
            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(i).equals(list.get(j))) {
                    return true;
                }
            }
        }
        return false;
    }
}
