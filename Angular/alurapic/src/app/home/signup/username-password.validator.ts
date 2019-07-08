import { ValidatorFn, FormGroup } from '@angular/forms';

export const userNamePasswordValidator: ValidatorFn = (formGroup: FormGroup) => {
    const userName: string = formGroup.get('userName').value;
    const password: string = formGroup.get('password').value;

    return !(userName.trim() + password.trim()) || userName != password ? null : { userNamePassword: true };
}