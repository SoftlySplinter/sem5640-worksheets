/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.alexanderdbrown.validators;

import javax.validation.ConstraintValidator;
import javax.validation.ConstraintValidatorContext;

/**
 * Validates a National Insurance Number (NINO).
 * <p>
 * A NINO is made up of two letters, six numbers and a final letter, which is
 * always A, B, C, or D.
 * <p>
 * Based on information from <a
 * href="http://www.hmrc.gov.uk/manuals/nimmanual/nim39110.htm">NIN39110</a>.
 *
 * @author Alexander D Brown
 * @version 1.0
 * @see NationalInsuranceNumber
 */
public class NationalInsuranceNumberValidator implements ConstraintValidator<NationalInsuranceNumber, String> {

    /**
     * Regular Expression for a NINO.
     * <p>
     * The characters D, F, I, Q, U and V are not used as either the first or
     * second letter of a NINO prefix. The letter O is not used as the second
     * letter of a prefix.
     * <p>
     * The numbers can just be any decimal number. For convenience they can be
     * separated by a whitespace character.
     * <p>
     * The suffix can be "A", "B", "C" or "D".
     * <p>
     * In regular expression form this is: <code>{@value}</code>
     */
    private static final String NI_REGEX = "[A-Z&&[^DFIQUV]][A-Z&&[^DFIQUVO]](\\s?\\d{2}){3}\\s?[A-D]";

    @Override
    public void initialize(NationalInsuranceNumber constraintAnnotation) {
        // Nothing to do
    }

    @Override
    public boolean isValid(String value, ConstraintValidatorContext context) {
        return value != null && value.matches(NI_REGEX);
    }

}
