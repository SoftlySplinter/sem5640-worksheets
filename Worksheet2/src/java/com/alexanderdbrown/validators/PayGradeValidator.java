/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.alexanderdbrown.validators;

import javax.validation.ConstraintValidator;
import javax.validation.ConstraintValidatorContext;

/**
 * Validates a Pay Grade.
 * <p>
 * The pay grade can be an integer between 1 and 8.
 *
 * @author Alexander D Brown
 * @version 1.0
 */
public class PayGradeValidator implements ConstraintValidator<PayGrade, Integer> {

    private static final Integer MIN_PAY_GRADE = 1;
    private static final Integer MAX_PAY_GRADE = 8;

    @Override
    public void initialize(PayGrade constraintAnnotation) {
        // Nothing to do.
    }

    @Override
    public boolean isValid(Integer value, ConstraintValidatorContext context) {
        if (value == null) {
            return false;
        }
        return value >= MIN_PAY_GRADE && value <= MAX_PAY_GRADE;
    }

}
