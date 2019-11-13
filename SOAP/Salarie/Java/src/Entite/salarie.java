package Entite;

public class salarie {
	private int code;
	private String nom;
	private  String prenom ;
	private String Adrs;
	private String fonct;
	private String Depts;
	private String Email;
	private int tel;
	
	public salarie(int code,String nom, String prenom, String adrs, String fonct, String depts, String email, int tel) {
		
		this.nom = nom;
		this.prenom = prenom;
		Adrs = adrs;
		this.fonct = fonct;
		Depts = depts;
		Email = email;
		this.tel = tel;
		this.code=code;
	}
	
	public int getCode() {
		return code;
	}

	public void setCode(int code) {
		this.code = code;
	}

	public String getNom() {
		return nom;
	}
	public void setNom(String nom) {
		this.nom = nom;
	}
	public String getPrenom() {
		return prenom;
	}
	public void setPrenom(String prenom) {
		this.prenom = prenom;
	}
	public String getAdrs() {
		return Adrs;
	}
	public void setAdrs(String adrs) {
		Adrs = adrs;
	}
	public String getFonct() {
		return fonct;
	}
	public void setFonct(String fonct) {
		this.fonct = fonct;
	}
	public String getDepts() {
		return Depts;
	}
	public void setDepts(String depts) {
		Depts = depts;
	}
	public String getEmail() {
		return Email;
	}
	public void setEmail(String email) {
		Email = email;
	}
	public int getTel() {
		return tel;
	}
	public void setTel(int tel) {
		this.tel = tel;
	}
	

}
