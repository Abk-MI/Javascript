package app;

import javax.xml.ws.Endpoint;

import DAOservice.service;
import Entite.salarie;



public class Application {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Endpoint.publish("http://192.168.43.79:8095/", new service());
		System.out.println("service déployé à l'adresse : http://192.168.43.79:8099/DAOService/service?wsdl");
		service sr = new service ();
		salarie sa= new salarie(6,"is","ab","ma","pp","kk","mp",23);
		//salarie s2= new salarie(6,"aa","bb","cc","aa","bb","kk",25);
		sr.AjouteSalarie(sa);
		
		//sr.ModifieSalarie(sa,s2);
		sr.SupprimeSalarie(sa);
	}

}
