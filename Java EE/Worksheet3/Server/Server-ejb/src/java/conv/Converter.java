/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package conv;

import javax.ejb.Stateless;

/**
 *
 * @author softly
 */
@Stateless
public class Converter implements ConverterRemote {

    @Override
    public double cTof(double c) {
        return ((9.0D / 5.0D) * c) + 32;
    }

    @Override
    public double fToc(double f) {
        return (f - 32) * (5.0D / 9.0D);
    }

    // Add business logic below. (Right-click in editor and choose
    // "Insert Code > Add Business Method")
}
