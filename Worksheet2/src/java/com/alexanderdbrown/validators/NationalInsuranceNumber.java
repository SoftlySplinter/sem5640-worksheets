/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.alexanderdbrown.validators;

import java.lang.annotation.Documented;
import static java.lang.annotation.ElementType.ANNOTATION_TYPE;
import static java.lang.annotation.ElementType.FIELD;
import static java.lang.annotation.ElementType.METHOD;
import java.lang.annotation.Retention;
import static java.lang.annotation.RetentionPolicy.RUNTIME;
import java.lang.annotation.Target;
import javax.validation.Constraint;
import javax.validation.Payload;

/**
 * Validates a National Insurance Number (NINO) using the
 * {@link NationalInsuranceNumberValidator}
 *
 * @author Alexander D Brown
 * @version 1.0
 */
@Target({METHOD, FIELD, ANNOTATION_TYPE})
@Retention(RUNTIME)
@Constraint(validatedBy = NationalInsuranceNumberValidator.class)
@Documented
public @interface NationalInsuranceNumber {
    String message() default "{NINO}";
    Class<?>[] groups() default {};
    Class<? extends Payload>[] payload() default {};
}
