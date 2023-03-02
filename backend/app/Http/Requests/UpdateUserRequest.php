<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class UpdateUserRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     *
     * @return bool
     */
    public function authorize()
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, mixed>
     */
    public function rules()
    {
        return [
	    "pid" =>"required",
            "username" =>"required|min:3",
            "email" =>"required",
            "password"=>"required",
            "firstName"=>"required",
            "lastName"=>"required",
            "gender"=>"required",
            "birthday"=>"required",
            "phone"=>"required",
            "address"=>"required",
            "city"=>"required", 
            "state"=>"required",
            "zipcode"=>"required",
            "country"=>"required",
        ];
    }
}
