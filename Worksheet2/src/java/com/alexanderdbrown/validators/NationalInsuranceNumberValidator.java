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
     * Regular Expression for the NINO prefix.
     * <p>
     * A prefix is chosen and then used until all the possible numbers have been
     * allocated. Then another prefix is used but not necessarily the next one
     * alphabetically. The characters D, F, I, Q, U and V are not used as either
     * the first or second letter of a NINO prefix. The letter O is not used as
     * the second letter of a prefix.
     * <p>
     * In regular expression form this is: <code>{@value}</code>
     */
    private static final String NI_PREFIX_REGEX = "[A-Z&&[^DFIQUV]][A-Z&&[^DFIQUVO]]";

    /**
     * Regular Expression for the NINO suffix.
     * <p>
     * The suffix dates back to when contributions were recorded on cards which
     * were returned annually, staggered throughout the tax year. “A” meant the
     * card was to be returned in March; “B” in June; “C” in September and “D”
     * in December. Although contribution cards are no longer used, the suffix
     * has remained an integral part of the NINO.
     * <p>
     * In regular expression form this is: <code>{@value}</code>
     */
    private static final String NI_SUFFIX_REGEX = "[A-D]";

    /**
     * Regular Expression for a NINO.
     * <p>
     * In regular expression form this is: <code>{@value}</code>
     */
    private static final String NI_REGEX = NI_PREFIX_REGEX + " ?\\d{2} ?\\d{2} ?\\d{2} ?" + NI_SUFFIX_REGEX;

    @Override
    public void initialize(NationalInsuranceNumber constraintAnnotation) {
        // Nothing to do
    }

    @Override
    public boolean isValid(String value, ConstraintValidatorContext context) {
        if (value == null) {
            return false;
        }
        return value.matches(NI_REGEX);
    }

}
