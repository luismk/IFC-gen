
import {BaseIfc} from "./BaseIfc"
import {IfcLabel} from "./IfcLabel.g"
import {IfcDataOriginEnum} from "./IfcDataOriginEnum.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcschedulingtime.htm
 */
export abstract class IfcSchedulingTime extends BaseIfc {
	Name : IfcLabel // optional
	DataOrigin : IfcDataOriginEnum // optional
	UserDefinedDataOrigin : IfcLabel // optional

    constructor() {
        super()
    }
}