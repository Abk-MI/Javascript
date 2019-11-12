package CerclePK;
import javax.jws.WebMethod;
import javax.jws.WebService;

public @WebService class ServiceCercle implements IFonctionCercle{
	
	public @WebMethod double calculePerimetre(Cercle c) {
		return c.get_rayon() * 2 *3.14;
	}
	public @WebMethod double calculeSurface(Cercle c) {
		return c.get_rayon() * c.get_rayon() * 3.14;
	}
}
