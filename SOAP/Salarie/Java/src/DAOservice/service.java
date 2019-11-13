package DAOservice;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import javax.jws.*;

import Entite.salarie;
import IDAOService.IDAOSalarie;

import connection.connexion;

@WebService
public class service implements IDAOSalarie{
	
	connexion cnx;
	ArrayList <salarie> ls= new ArrayList<salarie>();
	
	public service () {
		
	}
	
	@WebMethod
	@Override
	public ArrayList<salarie> RecupereListeSalarie() {
		
		try {
			
			cnx = new connexion();
			Connection cn = cnx.connexionDB();
			String requete="SELECT * FROM `salaries`";
			
			Statement state = cn.createStatement();
			
			ResultSet r= state.executeQuery(requete);
			
			while (r.next()) {
				salarie s =new salarie(r.getInt(1),r.getString(2),r.getString(3),r.getString(3),r.getString(4),r.getString(5),r.getString(6),r.getInt(8));
				ls.add(s);
			}
			
			cn.close();
		} 
		catch (Exception e) {
			System.out.println(e.getMessage());
		}
		return ls;
	}
	@WebMethod
	@Override
	public String AjouteSalarie(salarie s) {
		try {	
			cnx = new connexion();
			Connection cn = cnx.connexionDB();
			String requete="INSERT INTO `salaries` (`code`, `nom`, `prenom`, `Adrs`, `Fonct`, `Depts`, `Emails`, `tels`) VALUES('"+s.getCode()+"','"+s.getNom()+"','"+s.getPrenom()+"','"+s.getAdrs()+"','"+s.getFonct()+"','"+s.getDepts()+"','"+s.getEmail()+"','"+s.getTel()+"')";
			Statement state = cn.createStatement();
			
			state.executeUpdate(requete);
				
			cn.close();
			return "Ajout avec succés";
		}catch (Exception e) {
			return e.getMessage();
		}
		
	}
	@WebMethod
	@Override
	public String ModifieSalarie(salarie s1,salarie s2) {
		try {
			cnx = new connexion();
			Connection cn = cnx.connexionDB();
			String requete="UPDATE `salaries` SET `nom` = '"+s2.getNom()+"', `prenom` = '"+s2.getPrenom()+"', `Adrs` = '"+s2.getAdrs()+"', `Fonct` = '"+s2.getFonct()+"', `Depts` = '"+s2.getDepts()+"', `Emails` = '"+s2.getEmail()+"', `tels` = '"+s2.getTel()+"' WHERE `salaries`.`code` = "+s1.getCode()+";";
			Statement state = cn.createStatement();
			state.executeUpdate(requete);
			
			cn.close();
			return "Modifier avec succés";
		}
		catch (Exception e) {
			System.out.println(e.getMessage());
			return e.getMessage();
		}
	}
	@WebMethod
	@Override
	public boolean SupprimeSalarie(salarie s) {
		try {
			cnx = new connexion();
			Connection cn = cnx.connexionDB();
			String requete="DELETE FROM `salaries` WHERE `salaries`.`code` = "+s.getCode()+";";
			Statement state = cn.createStatement();
			state.executeUpdate(requete);
			
			cn.close();
			return true;
		}
		catch (Exception e) {
			System.out.println(e.getMessage());
			return false;
		}
	}

}
