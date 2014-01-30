package beans;

import java.io.Serializable;

import javax.enterprise.context.SessionScoped;
import javax.faces.application.FacesMessage;
import javax.faces.component.UIComponent;
import javax.faces.component.UIInput;
import javax.faces.context.FacesContext;
import javax.inject.Named;

import org.hibernate.validator.constraints.Length;
import org.hibernate.validator.constraints.Email;

@Named
@SessionScoped
public class Person implements Serializable {
	private String name;
	private String address;
	
	@Length(min=5, max=20)
	private String phone;
	
	@Email
	private String email;

	/**
	 * @return the name
	 */
	public String getName() {
		return name;
	}

	/**
	 * @param name
	 *            the name to set
	 */
	public void setName(String name) {
		this.name = name;
	}

	/**
	 * @return the address
	 */
	public String getAddress() {
		return address;
	}

	/**
	 * @param address
	 *            the address to set
	 */
	public void setAddress(String address) {
		this.address = address;
	}

	/**
	 * @return the phone
	 */
	public String getPhone() {
		return phone;
	}

	/**
	 * @param phone
	 *            the phone to set
	 */
	public void setPhone(String phone) {
		this.phone = phone;
	}

	public void validatePhone(FacesContext context, UIComponent toValidate,
			Object value) {
		if (!(value instanceof String)) {
			((UIInput) toValidate).setValid(false);
			context.addMessage(
					toValidate.getClientId(context),
					new FacesMessage("Not a String",
							"Expected a phone number but receviced something else"));
			return;
		}
		String phone = (String) value;
		if(!phone.matches("\\d+")) {
			((UIInput) toValidate).setValid(false);
			context.addMessage(toValidate.getClientId(context), new FacesMessage("Phone number contains alphabetic characters", "Phone numbers should only contain digits."));
		}
	}

	/**
	 * @return the email
	 */
	public String getEmail() {
		return email;
	}

	/**
	 * @param email
	 *            the email to set
	 */
	public void setEmail(String email) {
		this.email = email;
	}

	public Person() {

	}
}
