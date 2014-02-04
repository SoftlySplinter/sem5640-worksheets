/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.alexanderdbrown.validators;

import javax.validation.ConstraintValidator;
import javax.validation.ConstraintValidatorContext;

/**
 *
 * @author Alexander D Brown
 */
public class PhoneNumberValidator implements ConstraintValidator<PhoneNumber, String>{
    private static final String PHONE_REGEX = "^\\+(?:[0-9] ?){6,14}[0-9]$";
    
    
    @Override
    public void initialize(PhoneNumber constraintAnnotation) {
        // Nothing to do.
    }

    @Override
    public boolean isValid(String value, ConstraintValidatorContext context) {
        if(value == null) return false;
        return value.matches(PHONE_REGEX);
    }
    
}
