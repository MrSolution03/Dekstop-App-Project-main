import java.sql.*;
import javax.swing.UIManager;
public class Connect {
        Connection connec;
    
    public String Connect(){
        try{
        Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        
        connec = DriverManager.getConnection("jdbc:sqlserver://localhost:1433;databaseName=Movie_Max;"
                + "user=sa;password=1234");
        }catch(SQLException e){
            System.out.println("Error" + e.toString());
        }catch(ClassNotFoundException cnfe){
            System.out.println("Error " + cnfe.toString());
        }return "Connected";
    }
    
    public String Login(String username, String password_){
        String disp = null;
        
        try{
            String database = Connect();
            
            if (database == "Connected"){
                Statement st = connec.createStatement();
                
               ResultSet users = st.executeQuery(
                "SELECT * FROM users WHERE username ="
                        + " '" + username +"'AND password_ ="
                                + " '" + password_ + " '");
               users.next();
               String userna = users.getString("username");
               String passwo = users.getString("password_");
               
               if ( username == userna & password_ == passwo){
                   disp = "Ok";
               }else{
                   disp = "Ko";
               }
            }else{
                disp = "0";
            }
        } catch(SQLException e){
            System.out.println("Error" + e.toString());
        }return disp;
    }
    
    
    public String addMovie(String movieID,
    String movieName, String descriptions, String genreID){
        String ret = null;
        
        try{
            String database = Connect();
            
            if (database == "Connected"){
                Statement st = connec.createStatement();
    String queRy = "INSERT INTO movie(movieID, movieName,"
            + " descriptions,genreID) VALUES(" + movieID
            + ",'" + movieName + ",'" + descriptions + ",'" + genreID + ")";
            st.executeUpdate(queRy);
            }else{
                ret = "Operation failed";
            }
        }catch (SQLException e){
            System.out.println("Error" + e.toString());
        }return ret;
    }
    
    public String addGenre(String genreID, String genreName ){
        String ret = null;
        
        try{
            String database = Connect();
            if (database == "Connected"){
                Statement st = connec.createStatement();
                String queRy = "INSERT INTO genre(genreID, genreName)"
                        + "VALUES (" + genreID + ",'" + genreName + ")";
                st.executeUpdate(queRy);
            }else{
                ret = "Operation failed";
            }
        }catch(SQLException e){
            System.out.println("Error" + e.toString());
        }return ret;
    }
    
    public String deleteMovie(String movieID){
        String ret = null;
        try{
            String database = Connect();
            if (database == "Connected"){
                Statement st = connec.createStatement();
                String queRy = "DELETE FROM movie WHERE movieID = " 
                        + movieID + "";
                st.executeUpdate(queRy);
                ret = "Operation Succeed";
            }else{
                ret = "Opertion failed";
            }
        }catch(SQLException e){
            
        }return ret;
    }
    
    public String searchMovie(String movieName){
        String ret = null;
        
        try{
            String database = Connect();
            if (database == "Connected"){
                Statement st = connec.createStatement();
                String queRy = "SELECT * FROM movie WHERE movieName LIKE '%" + movieName + "%'";
                ResultSet resu = st.executeQuery(queRy);
                
                String display = null;
                
                while(resu.next()){
                    String name = resu.getString("movieName");
                    int movieID = resu.getInt("movieID");
                    String descriptions = resu.getString("descriptions");
                    int genreID = resu.getInt("genreID");
                    
                    display = "Movie ID: " + movieID + "\n" + "Movie Name: " + movieName + "\n" + "Movie Description: "
                            + descriptions + "\n" + "Genre ID" + genreID;
                }
                ret = display;
            }else {
                ret = "Movie not found";
            }
        }catch(SQLException e){
            System.out.println("Error" + e.toString());
        }return ret;
    }
}
