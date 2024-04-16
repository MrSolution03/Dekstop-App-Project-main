import java.io.*;
import java.net.*;
import javax.swing.*;
public class serverConnection {
    ServerSocket servSock;
    boolean listening;
    
    public serverConnection(){}
        public boolean start(){
           try{
               servSock = new ServerSocket(19000);
               listening = true;
           }catch(IOException e){
               System.out.println(e.toString());
           }
           
            System.out.println("The Server has just start running.");
            JOptionPane.showMessageDialog(null, "The Server has just start running.");
            
            while(listening){
                try{
                    new Session(servSock.accept());
                }catch(IOException e){
                    System.out.println(e.toString());
                }
            }
        return listening;
        }
        
        public boolean stop(){
            listening = false;
            System.out.println("The Server has been Stopped.");
            JOptionPane.showMessageDialog(null, "The Server has been stopped. ");
            return listening;
        }
     public static void main(String args){
            new Server();
     }
}

class Session implements Runnable{
    Socket so;
    BufferedReader br;
    PrintWriter pw;
    Thread runner;
    
    Session(Socket s){
        so = s;
        try{
            br = new BufferedReader(new InputStreamReader(
             so.getInputStream()));
            pw = new PrintWriter(new BufferedOutputStream(
            so.getOutputStream()), true);
            pw.println("Welcome");
            System.out.println("Client connected: " + Thread.currentThread().getName());
            
        }catch(IOException e){
            System.out.println(e.toString());
        }
        
        if (runner == null){
            runner = new Thread(this);
            runner.start();
        }
    }
    
    public void run(){
        while(runner == Thread.currentThread()){
            try{
                String input = br.readLine();
                
                if (input != null){
                    String output = Protocol.processInput(input);
                    pw.println(output);
                    
                    if(output == "Good Bye"){
                        runner = null;
                        pw.close();
                        br.close();
                        so.close();
                    }
                }
            }catch(IOException e){
                System.out.println(e.toString());
        }
            try{
                Thread.sleep(10);
            }catch(InterruptedException ie){
                System.out.println(ie.toString());
         } 
      }
   }
}

class Protocol{
       static Connect conn = new Connect();
       public static String processInput(String input){
         String sp = input;
         String delete = "-";
         String[]arrayInput;
         
         arrayInput = sp.split(delete);
           System.out.println("input");
           System.out.println(arrayInput[0]);
           if(arrayInput[0].toString().equalsIgnoreCase("Login")){
               String res = conn.Login(arrayInput[1], arrayInput[2]);
               System.out.println(arrayInput[1] + arrayInput[2]);
            
               return res;
           }else if(arrayInput[0].toString().equalsIgnoreCase("Add Movie")){
               String res = conn.addMovie(arrayInput[1], arrayInput[2], arrayInput[3], arrayInput[4]);
               System.out.println(arrayInput[1] + arrayInput[2] + arrayInput[3] +arrayInput[4]);
               return res;
           }else if(arrayInput[0].toString().equalsIgnoreCase("Add Genre")){
               String res = conn.addGenre(arrayInput[1], arrayInput[2]);
               System.out.println(arrayInput[1] + arrayInput[2]);
               return res;
           }else if (arrayInput[0].toString().equalsIgnoreCase("Delete")){
               String res = conn.deleteMovie(arrayInput[0]);
               System.out.println(arrayInput[0]);
               return res;
           }else if(arrayInput[0].toString().equalsIgnoreCase("Search")){
           String res = conn.searchMovie(arrayInput[1]);
               System.out.println(arrayInput[1]);
               return res;
       }else{
               return "Good Bye";
           }
       
}
}