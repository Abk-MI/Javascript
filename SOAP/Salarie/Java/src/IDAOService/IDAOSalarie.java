package IDAOService;
import java.util.ArrayList;

import Entite.salarie;


public interface IDAOSalarie {
	ArrayList<salarie>RecupereListeSalarie();
	String AjouteSalarie(salarie s);
	String ModifieSalarie(salarie s,salarie s2);
	boolean SupprimeSalarie(salarie s);

}
