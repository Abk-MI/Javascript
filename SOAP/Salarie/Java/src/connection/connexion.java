package connection;

import java.sql.Connection;
import java.sql.DriverManager;

public class connexion {
	public Connection cn= null;
	public connexion() {}
	public Connection connexionDB() {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			System.out.println("Driver okk");
			String url="jdbc:mysql://localhost:3306/salarie";
			String user="root";
			String password="";
			Connection cnx = DriverManager.getConnection(url, user, password);
			System.out.println("connexion établie avec succée");
			return cnx;
		}
		catch(Exception e) {
			e.printStackTrace();
			return null;
		}
	}
}
