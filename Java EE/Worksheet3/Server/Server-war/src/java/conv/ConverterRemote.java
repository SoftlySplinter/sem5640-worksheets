/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package conv;

import javax.ejb.Remote;

/**
 *
 * @author softly
 */
@Remote
public interface ConverterRemote {

    double cTof(double c);

    double fToc(double f);
}
