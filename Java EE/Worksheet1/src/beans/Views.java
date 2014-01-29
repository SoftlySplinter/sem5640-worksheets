package beans;

import java.io.Serializable;

import javax.enterprise.context.ApplicationScoped;
import javax.inject.Named;

@Named
@ApplicationScoped
public class Views implements Serializable {
	private int count;
	
	public Views() {}
	
	public int getCount() {
		return ++this.count;
	}
	
	public void setCount(int count) {
		this.count = count;
	}
	
}
